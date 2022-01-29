    import React from "react";
    import './Popup.css'
    
    function Popup(props :any){
        return (props.trigger) ? (
            <div className="popup">
                    <div className="popup-inner">
                            <button className="close-btn"></button>
                            {props.children }
                    </div>
            </div>
        ):"";
    }
    export default Popup;