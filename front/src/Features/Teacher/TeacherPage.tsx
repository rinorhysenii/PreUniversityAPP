import React from "react"
import 'bootstrap/dist/css/bootstrap.min.css';
import { Button, List, Header, Icon, Image, Input, Segment } from 'semantic-ui-react';

import '../../Features/Teacher/Teacher.css';
import Popup from "../Popup/Popup";

function TeacherPage(){
    return(
        <div className="lista">
            <ul className="list-group list-group-flush">

                <li className="list-group-item">Emri Mbiemri <button className="bttn"> Shiko</button></li>
                <li className="list-group-item">Emri Mbiemri <button className="bttn"> Shiko</button> </li >
                <li className="list-group-item">Emri Mbiemri <button className="bttn"> Shiko</button> </li>
                <li className="list-group-item">Emri Mbiemri <button className="bttn"> Shiko</button> </li>
                <li className="list-group-item">Emri Mbiemri <button className="bttn"> Shiko</button> </li>

            </ul>
         
        </div>
    )
}
export default TeacherPage;