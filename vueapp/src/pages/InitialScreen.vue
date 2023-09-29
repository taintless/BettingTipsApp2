<template>
  <v-container id="input-usage" fluid>
    <v-row>
      <v-col cols="4" offset="4">
        Welcome to Betting Tips application. Please enter email and<br />Get Started!
        <v-text-field v-model="email" label="Email"></v-text-field>
        <v-btn @click="userSubmted">
          Submit
        </v-btn>
      </v-col>
    </v-row>
  </v-container>
</template>

<script lang="js">
import { defineComponent } from 'vue';

export default defineComponent({
        data() {
            return {
                email: '',
            };
        },
  methods: {
    async userSubmted(){
      await this.$http.post('api/RegisteredUser', {email: this.email})
      alert(this.email);
    }
  }
});
</script>