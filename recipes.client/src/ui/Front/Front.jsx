import React from 'react'
import SearchBar from '../Search/SearchBar'

export default function Front({recipes}) {

    

    return (
        <div>
           <SearchBar recipes={recipes}/>
        </div>
    )
}
