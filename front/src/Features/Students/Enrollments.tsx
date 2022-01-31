import { observer } from "mobx-react-lite";
import React, { useEffect } from "react";
import { useStoreStudentat } from "../../Stores/Store";





export default observer(function EnrollmentsPage () {
    const {StudentatStore}=useStoreStudentat();
    const{Studentat,test,Courses}=StudentatStore;

    useEffect(()=>{
        StudentatStore.loadStudentat();
    },[EnrollmentsPage]);

return(
    <div>
        <table className="ui single line table">
  <thead>
    <tr>
      <th>Title</th>
      <th>Category</th>
      
      
    </tr>
  </thead>
  <tbody>
      {Courses.map((item)=>(
        <tr>
      <td>{item.title}</td>
      <td>{item.category}</td>
      
    </tr>
    
      ))}
    
  </tbody>
</table>
      
    </div>

);

});
