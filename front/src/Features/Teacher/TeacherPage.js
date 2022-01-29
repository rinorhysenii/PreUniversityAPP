import React, {useState} from "react"
import 'bootstrap/dist/css/bootstrap.min.css';
import { Button, List, Header, Icon, Image, Input, Segment } from 'semantic-ui-react';
import Modal  from '../../Components/Popup/Modal'
import '../../Features/Teacher/Teacher.css';
import { GlobalStyle } from '../../globalStyles';
import styled from 'styled-components';




function TeacherPage(){

    const [showModal, setShowModal] = useState(false);
    
    const openModal = () =>{
        setShowModal(prev => !prev);
    }

    const Container = styled.div`
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
`;

const Button = styled.button`
  min-width: 100px;
  padding: 16px 32px;
  border-radius: 4px;
  border: none;
  background: #141414;
  color: #fff;
  font-size: 24px;
  cursor: pointer;
`;

    return(
        <>
      <Container>
          
            
       
       
        <div className="lista">      
        
            <ul className="list-group list-group-flush">

                <li className="list-group-item">Emri Mbiemri <button className="bttn" onClick={openModal}> Shiko</button></li>                                                                  
                <li className="list-group-item">Emri Mbiemri <button className="bttn" onClick={openModal}> Shiko</button> </li >
                <li className="list-group-item">Emri Mbiemri <button className="bttn"onClick={openModal}> Shiko</button> </li>
                <li className="list-group-item">Emri Mbiemri <button className="bttn"onClick={openModal}> Shiko</button> </li>
                <li className="list-group-item">Emri Mbiemri <button className="bttn"onClick={openModal}> Shiko</button> </li>
              
            </ul>
            
           
        </div>
        <Modal showModal={showModal} setShowModal={setShowModal} />
        <GlobalStyle />
        </Container>
      
        </>
    )
}
export default TeacherPage;