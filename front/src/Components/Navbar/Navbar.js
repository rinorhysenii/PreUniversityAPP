import React from 'react'
import './Navbar.css';



const Navbar = () => {
    return(
      
        <nav class="navbar navbar-expand-lg navbar-light">
             
  <a class="navbar-brand" id='shkolla' href="#"><img src={require('../../Features/Login/logo.png')} alt='s' style={{width:100}}  /></a>
 

  <div class="collapse navbar-collapse" id="navbarSupportedContent">
    <ul class="navbar-nav mr-auto">
      <li class="nav-item active">
        <a class="nav-link" id='home' href="#">Home <span class="sr-only">(current)</span></a>
      </li>
    </ul>
    <form class="form-inline my-2 my-lg-0">
      
    
    </form>
  </div>
</nav>

    )
}
export default Navbar;