import React from 'react';
import { Button, Container, Header, Icon, Image, Input, Segment } from 'semantic-ui-react';
import { Link } from 'react-router-dom';
import '../../Features/Login/style.css';

function LoginPage(){

    return(
        <Segment inverted textAlign='center' vertical className='masthead'>
        <Container className='aaad' text>
            
             <div className='kkk'>
            <Header as='h1' inverted > 
                <p data-text="School Management System"> School Management System</p>  
            </Header>
            </div>


            <div className='logoja'>
                <img src={require('./logo.png')} alt='s' style={{width:300,marginBottom:12}} className='logo' />
            </div>
                <>
                    <Header as='h2'  className='asas' inverted content='Welcome to Hospital Management System' />

                    <div className='forma'>
                        <div className="wrapper">
                        <input className="search" type="text" id="search" />
                      
                    </div>
                    <div className="wrapper">
                        <input className="search" type="text" id="search" />
                        <input className="submit" type="submit" value=" " />
                    </div>
                    </div>
                </>
            
            
        </Container>
 </Segment>
    )
}
export default LoginPage;