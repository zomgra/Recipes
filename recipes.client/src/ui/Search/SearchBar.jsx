import React, { useState } from 'react'
import RecipeSearchBox from './RecipeSearchBox';

export default function SearchBar({ recipes }) {

    const [searchIngredients, setSearchIngreadients] = useState([]);
    const [query, setQuery] = useState(null)

    async function selectRecipe(recipeId){
      window.location.href = `recipe/${recipeId}`
    }

    async function searchIngredient(query) {
        setQuery(query);
        console.log(recipes);
        const filteredData = recipes.filter((r) => {
            return r.ingredientInfos.some((i) => {
                return i.ingredient.name.toLowerCase().includes(query.toLowerCase());
            });
        });
        await setSearchIngreadients(filteredData);
    };

    return (
        <div className='container'>
            <input placeholder='Enter ingredient name' onChange={(e) => { searchIngredient(e.target.value) }} />
            {searchIngredients.length}
            {searchIngredients.length > 0 && (
                <ol className="list-group list-group-numbered my-2 align-items-center">
                    {searchIngredients.map((recipe) => (
                        <RecipeSearchBox  key={recipe.id} recipe={recipe} selectRecipe={selectRecipe} />
                    ))}
                </ol>
            )}
        </div>
    )
}

