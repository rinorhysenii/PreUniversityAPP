import React from 'react';
import ReactDOM from 'react-dom';
import 'bootstrap/dist/css/bootstrap.min.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import { store, StoreContext, StoreContextStudentat } from './Stores/Store';
import StudentatStore from './Stores/StudentatStore';

ReactDOM.render(
  <StoreContextStudentat.Provider value={store}>
  
    <App />
    </StoreContextStudentat.Provider>,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
