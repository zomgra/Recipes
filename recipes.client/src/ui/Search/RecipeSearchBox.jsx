import React from 'react'

export default function RecipeSearchBox({recipe, selectRecipe}) {
  return (
    <button className='list-group-item' onClick={()=>selectRecipe(recipe.id)}>
        {recipe.name}
    </button>
  )
}
