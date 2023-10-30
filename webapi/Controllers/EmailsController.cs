using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using webapi.Models;
using System.Net.Http;
using webapi.Db;
using System.Collections.Generic;
using System;
using webapi.Db.Entities;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmailsController(AppDbContext context)
        {
            this._context = context;
        }
        [HttpPost]
        public ActionResult SendEmail(SendEmailResource sendEmailData)
        {
            var userEmails = _context.RegisteredUsers.Where(x => sendEmailData.Users.Any(y => y == x.Id)).ToList();
            var games = _context.Games.Where(x => sendEmailData.Games.Any(y => y == x.Id)).ToList();

            var random = new Random();

            var userGame = userEmails.Select(x => {
                int index = random.Next(games.Count);
                return new { User = x, Game = games[index] };
            }).ToList();

            userGame.ForEach(x =>
            {
                var teamToBet = x.Game.TeamToBet == 0 ? x.Game.Team1Name : x.Game.Team2Name;
                var text = $"Hello, my friend,\r\n\r\nI hope this message finds you well. I have some exciting news to share with you. Our experts have identified a thrilling betting opportunity that might pique your interest.\r\n\r\nThe opportunity we've uncovered is {x.Game.Team1Name} - {x.Game.Team2Name} game in {x.Game.League} league. We have discovered 95% probability for the team {teamToBet} to win. We believe it holds significant potential, but as always, we emphasize the importance of responsible betting.\r\n\r\nEnjoy the excitement of betting and winning.\r\n\r\nWishing you the best of luck,\r\n\r\nBetting professional community.";

                try
                {
                    SendEmail(x.User.Email, text);
                    _context.Add(new UserGame
                    {
                        Id = Guid.NewGuid(),
                        GameId = x.Game.Id,
                        RegisteredUserId = x.User.Id,
                        Succeed = true,
                        Timestamp = DateTime.Now
                    });
                }
                catch (Exception e)
                {
                    _context.Add(new UserGame
                    {
                        Id = Guid.NewGuid(),
                        GameId = x.Game.Id,
                        RegisteredUserId = x.User.Id,
                        Succeed = false,
                        FailureMessage = e.Message,
                        Timestamp = DateTime.Now
                    });
                }
                finally
                {
                    _context.SaveChanges();
                }
            });

            return Ok();
        }

        private static void SendEmail(string recipient, string text)
        {
            var smtpClient = new SmtpClient("smtp-relay.sendinblue.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("jokubas.raila@gmail.com", "I159ryvVF4MzS0fj"),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("betting.professionals@gmail.com"),
                Subject = "Oportunity to win money uncovered",
                Body = text,
                IsBodyHtml = true,
            };

            mailMessage.To.Add(recipient);

            smtpClient.Send(mailMessage);
        }
    }
}
