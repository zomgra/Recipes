import axios from 'axios';
import { DEFAULT_API_URL } from '../utils/Constants';

const instance = axios.create({
    baseURL: DEFAULT_API_URL,
});

export function getAllInfoRecipes() {
    var jsonRes;

    instance.get('/recipe',{
        method:"GET"
    }).then(responce=>console.log(responce)).then(json=> jsonRes = json)
    .catch(e=> console.error(e))

    console.log(jsonRes);
    return jsonRes;
}

export function getAllRecipes() {
    var jsonRes;

    instance.get('/recipe',{
        method:"GET"
    }).then(responce=>console.log(responce)).then(json=> jsonRes = json)
    .catch(e=> console.error(e))

    console.log(jsonRes);
    return jsonRes;
}
export function getAllIngredients() {
    var jsonRes;

    instance.get('/ingredient',{
        method:"GET"
    }).then(responce=>responce.json()).then(json=> jsonRes = json)
    .catch(e=> console.error(e))

    console.log(jsonRes);
    return jsonRes;
}