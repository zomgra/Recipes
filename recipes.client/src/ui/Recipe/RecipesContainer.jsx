import React from 'react'
import RecipeSmallInfo from './RecipeSmallInfo'

export default function RecipesContainer({recipes}) {

    return (
        <div>
           {recipes.map(rec =>
            <RecipeSmallInfo key={rec.id} recipe={rec}/>)}
        </div>
    )
}
