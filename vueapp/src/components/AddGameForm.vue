<template>
    <v-expansion-panels v-model="panel">
        <v-expansion-panel>
            <v-expansion-panel-title>Add game</v-expansion-panel-title>
            <v-expansion-panel-text>
                <v-form>
                    <v-container>
                        <v-row>
                            <v-col cols="4">
                                <v-text-field v-model="team1Name" label="Team 1 name"></v-text-field>
                            </v-col>
                        </v-row>
                        <v-row>
                            <v-col cols="4">
                                <v-text-field v-model="team2Name" label="Team 2 name"></v-text-field>
                            </v-col>
                        </v-row>
                        <v-row>
                            <v-col cols="4">
                                <v-text-field v-model="league" label="League"></v-text-field>
                            </v-col>
                        </v-row>
                        <v-row>
                            <v-col cols="4">
                                <v-text-field v-model="teamToBet" label="Bet (0, 1)"></v-text-field>
                            </v-col>
                        </v-row>
                        <v-row>
                            <v-col cols="4">
                                <v-text-field v-model="gameTime" label="Game time"></v-text-field>
                            </v-col>
                        </v-row>
                        <v-row>
                            <v-col>
                                <v-btn @click="gameSubmited">
                                    Submit
                                </v-btn></v-col>
                        </v-row>
                    </v-container>
                </v-form>
            </v-expansion-panel-text>
        </v-expansion-panel>
    </v-expansion-panels>
</template>

<script>
export default {
    components: {
    },
    data: () => ({
        team1Name: '',
        team2Name: '',
        league: '',
        teamToBet: '',
        gameTime: null,
        panel: []
    }),
    methods: {
        reset() {
            this.team1Name = '';
            this.team2Name = '';
            this.league = '';
            this.teamToBet = '';
            this.gameTime = null;
        },
        async gameSubmited() {
            let { team1Name, team2Name, league, teamToBet, gameTime } = this;
            await this.$http.post('api/Games', { team1Name, team2Name, league, teamToBet, gameTime })
            this.reset();
            this.panel = [];
            this.$emit('gameCreated');
        }
    }
}
</script>