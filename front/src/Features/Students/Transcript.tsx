import { observer } from "mobx-react-lite";
import React, { useEffect } from "react";
import { useStoreStudentat } from "../../Stores/Store";





export default observer(function TranscriptPage () {
    const {StudentatStore}=useStoreStudentat();
    const{Studentat,test,Transkript}=StudentatStore;

    useEffect(()=>{
        StudentatStore.loadStudentat();
    },[TranscriptPage]);

return(
    <div>
        <table className="ui single line table">
  <thead>
    <tr>
      <th>Lenda</th>
      <th>Nota</th>
      
      
    </tr>
  </thead>
  <tbody>
      {Transkript.map((item)=>(
        <tr>
      <td>{item.title}</td>
      <td>{item.mark}</td>
      
    </tr>
      ))}
    
    
  </tbody>
</table>
      
    </div>

);

});
