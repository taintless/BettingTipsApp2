<template>
  <v-container fluid>
    <v-row>
      <v-col cols="12"> ADMIN PAGE </v-col>
      <!-- enter games -->
      <GamesToBet />
      <!-- send emails panel -->
      <!-- statistics -->
      <RegisteredUsers />
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
      users: [],
    };
  },
  components: {RegisteredUsers, GamesToBet},
  methods: {
    async getUsers() {
      var users = await this.$http.get('api/RegisteredUser');
      this.users = users;
    }
  }
});
</script>
