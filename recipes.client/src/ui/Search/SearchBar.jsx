import React, { useState } from 'react'

export default function SearchBar({ingredients}) {

    const [searchIngreadients, setSearchIngreadients] = useState([]);
    const [query, setQuery] = useState(null)

    function seacrhIngredient(query) {
        setQuery(query);
        let searchIngredients = ingredients.filter(ingredient => {
            ingredient.name.ToLowerCase().include(query.ToLowerCase())
        });
        if(seacrhIngredients) setSearchIngreadients(seacrhIngredients);
    }

  return (
    <div>
        <input placeholder='Enter ingredient name' onChange={(e)=> {seacrhIngredient(e.target.value)}}/>
        {(query !== null && query.length !== 0) && (    
            <div>
                {seacrhIngredients.map(ingredient => {
                    <div key={ingredient.id}>
                        <p>{ingredient.Name}</p>
                    </div>
                })}
            </div>
        )}
    </div>
  )
}
