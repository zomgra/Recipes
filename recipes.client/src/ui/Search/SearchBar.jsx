import React, { useState } from 'react'
import RecipeSearchBox from './RecipeSearchBox';

export default function SearchBar({ recipes }) {

    const [searchIngreadients, setSearchIngreadients] = useState([]);
    const [query, setQuery] = useState(null)

    async function selectRecipe(recipeId){
      window.location.href = `recipe/${recipeId}`
    }

    async function searchIngredient(query) {
        setQuery(query);
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
            {searchIngreadients.length}
            {searchIngreadients.length > 0 && (
                <ol className="list-group list-group-numbered my-2 align-items-center">
                    {searchIngreadients.map((recipe) => (
                        <RecipeSearchBox  key={recipe.id} recipe={recipe} selectRecipe={selectRecipe} />
                    ))}
                </ol>
            )}
        </div>
    )
}

