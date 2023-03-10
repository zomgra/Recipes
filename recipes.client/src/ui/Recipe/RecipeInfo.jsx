import React from 'react'
import { useParams } from 'react-router-dom';

export default function RecipeInfo() {
    const { id } = useParams(); 
  return (
    <div>RecipeInfo : {id}</div>
  )
}
