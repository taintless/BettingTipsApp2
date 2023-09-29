<template>
  <!-- <img alt="Vue logo" src="./assets/logo.png"> -->
  <InitialScreen/>
  <!-- <HW /> -->
  <!-- <AdminPage/> -->
</template>

<script>
// import HW from './components/HelloWorld.vue'
import InitialScreen from './pages/InitialScreen.vue'
// import AdminPage from './pages/AdminPage.vue'

export default {
  name: 'App',
  components: {
    InitialScreen, 
    // HW,
    // AdminPage
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
