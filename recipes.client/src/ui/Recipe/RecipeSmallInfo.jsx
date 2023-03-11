import React from 'react'
import { Link } from 'react-router-dom'

export default function RecipeSmallInfo({recipe}) {
    return (
        <div>
            <div class="container-fluid bg-light p-3">
                <div class="row justify-content-center align-items-center">
                    <div class="col-md-4">
                        <img src={recipe.imageUrl} alt="Model Image" class="img-fluid rounded" />
                    </div>
                    <div class="col-md-4">
                        <h4>Name:</h4>
                        <p class="lead">{recipe.name} </p>
                        <h4>Description:</h4>
                        <p class="lead"> {recipe.description} </p>
                        <Link to={`/recipe/${recipe.id}`} className='btn btn-primary'>More</Link>
                    </div>
                </div>
            </div>
            <hr/>
        </div>
    )
}
