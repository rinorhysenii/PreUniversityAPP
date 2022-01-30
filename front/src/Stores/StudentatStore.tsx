import { makeAutoObservable, runInAction } from "mobx";
import agent from "../axios/agent";
import { IStudentat } from "../intefaces/IStudentat";
import { ITeacher } from "../intefaces/ITeacher";


export default class StudentatStore{
    selectedTermini:IStudentat | undefined=undefined;
    editmode=false;
    StudentatRegistry=new Map<string,ITeacher>();
    test="Test from mobex";
    detailsmode=false;
   
    
   
    constructor(){
        makeAutoObservable(this)
    }
    loadStudentat= async ()=>{
       try{
        const students=await agent.Teachers.list();
        runInAction(()=>{
            students.forEach(studenti=>{
               
                this.StudentatRegistry.set(studenti.id,studenti);
        })
        
        })
       }
       catch(error){
           console.log(error);
       }
    }
    get Studentat(){
        return Array.from(this.StudentatRegistry.values());
    }
}