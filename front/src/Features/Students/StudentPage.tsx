
import { observer } from 'mobx-react-lite';
import React, { useEffect, useState } from 'react';
import { Button, Popup } from 'semantic-ui-react';
import { textSpanIntersectsWithPosition } from 'typescript';
import { useStoreStudentat } from '../../Stores/Store';
import Enrollments from './Enrollments';
import PopUp from './PopUp';
import Transcript from './Transcript';

export default observer(function StudentPage () {
    const {StudentatStore}=useStoreStudentat();
    const{Studentat,test,coursesDisplay,transcriptDisplay}=StudentatStore;

    useEffect(()=>{
        StudentatStore.loadStudentat();
    },[StudentPage]);
 function Courses(id:string){
     StudentatStore.openCorses(id);
     StudentatStore.coursesDisplay=true;
 }
 function Transcripts(id:string){
     StudentatStore.openTrascript(id);
    StudentatStore.transcriptDisplay=true;
 }
return(
    <div>
        <table className="ui single line table">
  <thead>
    <tr>
      <th>Name</th>
      <th>studentNumber</th>
      <th>Enrollments</th>
      <th>Transcript</th>
    </tr>
  </thead>
  <tbody>
    
        {Studentat.map((item)=>(
            <tr>
            <td>{item.name}</td>
            <td>{item.studentNumber}</td>
            <td>{<Button onClick={()=>Courses(item.id)} content={"Courses"} color='green'/>}</td>
            <td>{<Button onClick={()=>Transcripts(item.id)} content={"Transcript"} color='blue'/>}</td>
          </tr>
        )

        )};
      
    <PopUp
    openPopup={coursesDisplay}
                               >
        <Enrollments/>
     </PopUp>
     <Popup
        openPopup={transcriptDisplay}>
            <Transcript/>
     </Popup>
  </tbody>
</table>
      
    </div>

);

});