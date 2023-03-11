import React from 'react'
import RecipesContainer from '../Recipe/RecipesContainer'
import SearchBar from '../Search/SearchBar'

export default function Front({recipes}) {

    return (
        <div>
           <SearchBar recipes={recipes}/>
           <RecipesContainer recipes={recipes}/>
        </div>
    )
}
