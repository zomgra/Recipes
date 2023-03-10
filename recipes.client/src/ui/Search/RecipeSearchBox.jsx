import React from 'react'

export default function RecipeSearchBox({ recipe, selectRecipe }) {
  return (
      <li className="list-group-item d-inline-flex p-3 px-4 justify-content-between align-items-center" >
        <div className='ms-2 me-auto'>
          <div className=''>{recipe.name}</div>
          <button onClick={() => selectRecipe(recipe.id)}>Open</button>
        </div>
        {/* <span>{recipe.creationTime}</span> */}
      </li>
  );
}
