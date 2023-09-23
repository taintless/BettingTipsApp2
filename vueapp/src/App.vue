<template>
  <!-- <img alt="Vue logo" src="./assets/logo.png"> -->
  <!-- <InitialScreen/> -->
  <AdminPage/>
</template>

<script>
import InitialScreen from './pages/InitialScreen.vue'
import AdminPage from './pages/AdminPage.vue'

export default {
  name: 'App',
  components: {
    InitialScreen, 
    AdminPage
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
