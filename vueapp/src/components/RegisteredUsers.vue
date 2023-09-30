<template>
    <v-container fluid>
        <v-row>
            <v-col cols="12">
                Users:
                <v-table>
                    <thead>
                        <tr>
                            <th class="text-left">
                                Id
                            </th>
                            <th class="text-left">
                                Email
                            </th>
                            <th class="text-left">
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr v-for="user in users" :key="user.id">
                            <td>{{ user.id }}</td>
                            <td>{{ user.email }}</td>
                            <td><v-checkbox v-model="selectedUsers" @update:modelValue="$emit('selectedUsersUpdated', $event)" :value="user.id"></v-checkbox></td>
                        </tr>
                    </tbody>
                </v-table>
            </v-col>
        </v-row>
    </v-container>
</template>
  
<script lang="js">
import { defineComponent } from 'vue';

export default defineComponent({
    data() {
        return {
            users: [],
            selectedUsers: []
        };
    },
    mounted() {
        this.getUsers()
    },
    methods: {
        async getUsers() {
            var users = await this.$http.get('api/RegisteredUser');
            this.users = users.data;
        }
    }
});
</script>
  