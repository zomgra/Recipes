import React, { useState } from 'react'

export default function SearchBar({ingredients}) {

    const [searchIngreadients, setSearchIngreadients] = useState([]);
    const [query, setQuery] = useState(null)

    function searchIngredient(query) {
        setQuery(query);
        setSearchIngreadients(ingredients.filter(ingredient => {
            ingredient.name.ToLowerCase().include(query.ToLowerCase())
        }));
    }

  return (
    <div>
        <input placeholder='Enter ingredient name' onChange={(e)=> {searchIngredient(e.target.value)}}/>
        {(query !== null && query.length !== 0) && (    
            <div>
                {searchIngreadients.map(ingredient => {
                    <div key={ingredient.id}>
                        <p>{ingredient.Name}</p>
                    </div>
                })}
            </div>
        )}
    </div>
  )
}
