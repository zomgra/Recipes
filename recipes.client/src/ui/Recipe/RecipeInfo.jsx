import React, { useEffect, useState } from 'react'
import { useParams } from 'react-router-dom';
import { getRecipeById } from '../../services/recipeServise';

export default function RecipeInfo() {
    const { id } = useParams();
    const [recipe, setRecipe] = useState();
    useEffect(() => {
        async function getRecipe() {
            let recipe = await getRecipeById(id);
            console.log(recipe);
            setRecipe(recipe);
        }
        getRecipe();
    }, [])
    return (
        <div>
            <div className="jumbotron jumbotron-fluid bg-secondary">
                <div className="container">
                    <h1 class="text-center text-white display-1">{recipe.name}</h1>
                </div>
            </div>

            <div className="container my-5">
                <div className="row">
                    <div className="col-md-6">
                        <img src={recipe.imageUrl} alt={recipe.imageUrl} className="img-fluid"/>
                    </div>
                    <div className="col-md-6">
                        <h2 className="mb-4">Лучшее блюдо Украины</h2>
                        <p><strong>Описание:</strong></p>
                        <p>{recipe.description}</p>
                        <p><strong>Инструкция:</strong></p>
                        <ul>
                            <li>{recipe.instruction}</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    )
}
