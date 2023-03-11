import axios from 'axios';
import { DEFAULT_API_URL } from '../utils/Constants';

const instance = axios.create({
    baseURL: DEFAULT_API_URL,
});

export async function getAllInfoRecipes() {
    var responce = await instance.get('/recipe', {
        method: "GET"
    });
    return responce.data.recipes;
}

export async function getAllRecipes() {

    var responce = await instance.get('/recipe/full', {
        method: "GET"
    });
    console.log(responce.data);
    return responce.data;
}

export async function getRecipeById(id) {
    try {
        var responce = await instance.get(`/recipe/${id}`);
        return responce.data;
    } catch (error) {
        console.log(error);
        return null;
    }
}

export async function getAllIngredients() {

    let responce = await instance.get('/ingredient', {
        method: "GET"
    });
    return responce.data.ingredients;
}