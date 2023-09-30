<template>
    <v-container fluid>
        <v-row>
            <v-col cols="12">
                <AddGameForm @gameCreated="getGames" />
            </v-col>
        </v-row>
        <v-row>
            <v-col cols="12">
                Games:
                <v-table>
                    <thead>
                        <tr>
                            <th class="text-left">
                                Id
                            </th>
                            <th class="text-left">
                                MatchUp
                            </th>
                            <th class="text-left">
                                League
                            </th>
                            <th class="text-left">
                                Bet for
                            </th>
                            <th class="text-left">
                                Game time
                            </th>
                            <th class="text-left">
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr v-for="game in games" :key="game.id">
                            <td>{{ game.id }}</td>
                            <td>{{ game.team1Name }} - {{ game.team2Name }}</td>
                            <td>{{ game.league }}</td>
                            <td>{{ game.teamToBet }}</td>
                            <td>{{ game.gameTime }}</td>
                            <td><v-checkbox v-model="selectedGames" @update:modelValue="$emit('selectedGamesUpdated', $event)" :value="game.id"></v-checkbox></td>
                        </tr>
                    </tbody>
                </v-table>
            </v-col>
        </v-row>
    </v-container>
</template>
  
<script lang="js">
import { defineComponent } from 'vue';
import AddGameForm from './AddGameForm.vue'

export default defineComponent({
    data() {
        return {
            games: [],
            selectedGames: [],
        };
    },
    components: { AddGameForm },
    mounted() {
        this.getGames()
    },
    methods: {
        async getGames() {
            var games = await this.$http.get('api/Games');
            this.games = games.data;
        }
    }
});
</script>
  