<template>
    <v-container fluid>
        <v-row justify="center">
            <v-col cols="6">
                <v-text-field label="filter tags" v-model="filter" @keydown="filtering" clearable>
                    <v-icon slot="append" color="red">mdi-filter</v-icon>
                </v-text-field>
            </v-col>
        </v-row>
        <v-row justify="center">
            <v-col cols="8">
                <v-chip :class="item.size" :color="item.color" text-color="white" v-for="(item, i) in items" :key="i">
                    <v-avatar left>
                        <v-icon>mdi-label</v-icon>
                    </v-avatar>
                    {{item.text}}
                    <v-avatar right class="green darken-4">
                        {{item.articles}}
                    </v-avatar>
                </v-chip>
            </v-col>
        </v-row>
    </v-container>
</template>

<script>
    export default {
        data: () => ({
            filter: '',
            items: []
        }),
        mounted() {
            const colors = ['red', 'orange', 'indigo', 'primary', 'green', 'teal']

            this.items = []

            for (let i = 0; i < 100; i++) {
                this.items.push({
                    text: `Docker ${i}`,
                    articles: this.random(0, 100),
                    icon: 'mdi-label',
                    color: colors[this.random(0, colors.length - 1)],
                    size: `ma-${this.random(1, 5)}`
                })
            }
        },
        methods: {
            filtering() {
                console.log(this.filter)
            },
            random(min, max) {
                return Math.floor(Math.random() * (max - min) + min)
            }
        }
    }
</script>