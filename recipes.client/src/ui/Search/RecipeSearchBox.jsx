import React from 'react'
import { Link } from 'react-router-dom';

export default function RecipeSearchBox({ recipe, selectRecipe }) {
  return (
      <li className="list-group-item d-inline-flex p-3 px-4 justify-content-between align-items-center" >
        <div className='ms-2 me-auto'>
          <div className=''>{recipe.name}</div>
          <Link className='btn btn-info' to={`/recipe/${recipe.id}`}>Open</Link>
        </div>
        {/* <span>{recipe.creationTime}</span> */}
      </li>
  );
}
