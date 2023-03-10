import React, { useState } from 'react'
import RecipeSearchBox from './RecipeSearchBox';

export default function SearchBar({ recipes }) {

    const [searchIngreadients, setSearchIngreadients] = useState([]);
    const [query, setQuery] = useState(null)

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
            <ul className='list-group'>

                {searchIngreadients.map(recipe =>
                    <RecipeSearchBox key={recipe.id} recipe={recipe} />
                )}
            </ul>
        </div>
    )
}

