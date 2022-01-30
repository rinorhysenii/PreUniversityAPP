import { observer } from 'mobx-react-lite';
import React, { useEffect, useState } from 'react';
import { useStoreStudentat } from '../../Stores/Store';

export default observer(function StudentPage () {
    const {StudentatStore}=useStoreStudentat();
    const{Studentat,test}=StudentatStore;

    useEffect(()=>{
        StudentatStore.loadStudentat();
    },[StudentPage]);

return(
    <div>
      {Studentat.map((item)=>(
          <div key={item.id}>
          <h1>{item.name}</h1>
          </div>
      ))}
      <h1>test</h1>
    </div>

);

});