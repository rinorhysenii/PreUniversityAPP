import React from 'react';
import { Button, Container, Header, Icon, Image, Input, Segment } from 'semantic-ui-react';
import { Link } from 'react-router-dom';
import '../../Features/Login/style.css';

function LoginPage(){

    return(
        <Segment inverted textAlign='center' vertical className='masthead'>
        <Container className='aaad' text>
            
        
                <>
                <div className='fotto'><img src={require('./logo.png')} alt='s' style={{width:400}}  /></div>
                    <Header as='h1'  className='asas' inverted content='Welcome to School Management System' />

                    <div className='forma'>
                    <div className="wrappper">
    <header>Login Form</header>
    <form action="#">
      <div className="field email">
        <div className="input-area">
          <input type="text" placeholder="Email Address"/>
          <i className="icon fas fa-envelope"></i>
          <i className="error error-icon fas fa-exclamation-circle"></i>
        </div>
        <div className="error error-txt">Email can't be blank</div>
      </div>
      <div className="field password">
        <div className="input-area">
          <input type="password" placeholder="Password"/>
          <i className="icon fas fa-lock"></i>
          <i className="error error-icon fas fa-exclamation-circle"></i>
        </div>
        <div className="error error-txt">Password can't be blank</div>
      </div>
      <div className="pass-txt">Authenticate cr@</div>
      <input type="submit" value="Login"/>
    </form>
    <div className="sign-txt">Not yet member? <a href="#">Signup now</a></div>
  </div>
  <script src="script.js"></script>
                    </div>
                </>
            
            
        </Container>
 </Segment>
    )
}
export default LoginPage;