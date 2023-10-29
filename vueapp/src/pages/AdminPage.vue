<template>
    <v-container fluid>
        <v-row>
            <v-col cols="12"> ADMIN PAGE </v-col>
        </v-row>
        <v-row>
            <!-- enter games -->
            <GamesToBet @selectedGamesUpdated="selectedGamesUpdated" />
        </v-row>
        <v-row>
            <!-- statistics -->
            <RegisteredUsers @selectedUsersUpdated="selectedUsers = $event" />
        </v-row>
        <v-row>
            <!-- send emails panel -->
            <v-btn @click="sendEmailClicked">
                Send email
            </v-btn>
        </v-row>
    </v-container>
</template>

<script lang="js">
import { defineComponent } from 'vue';
import RegisteredUsers from '../components/RegisteredUsers.vue'
import GamesToBet from '../components/GamesToBet.vue'

export default defineComponent({
    data() {
        return {
            selectedGames: [],
            selectedUsers: []
        };
    },
    components: { RegisteredUsers, GamesToBet },
    methods: {
        selectedUsersUpdated(users) {
            this.selectedUsers = users;
        },
        selectedGamesUpdated(games) {
            this.selectedGames = games;
        },
        async sendEmailClicked(){
            await this.$http.post('api/Emails', {users: this.selectedUsers, games: this.selectedGames});
        }
    }
});
</script>
