<template>
  <v-container fluid>
    <v-row>
      <v-col cols="12"> ADMIN PAGE </v-col>
      <!-- enter games -->
      <GamesToBet @selectedGamesUpdated="selectedGamesUpdated" />
      <!-- send emails panel -->
      <!-- statistics -->
      <RegisteredUsers @selectedUsersUpdated="selectedUsers = $event" />
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
    }
  }
});
</script>
