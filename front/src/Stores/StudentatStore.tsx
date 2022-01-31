import { makeAutoObservable, runInAction } from "mobx";
import agent from "../axios/agent";
import { ICourse } from "../intefaces/Course";
import { IStudentat } from "../intefaces/IStudentat";
import { IStudentCourses } from "../intefaces/IStudentCourses";
import { ITeacher } from "../intefaces/ITeacher";


export default class StudentatStore{
    selectedStudenti:IStudentat | undefined=undefined;
    coursesDisplay=false;
    StudentatRegistry=new Map<string,IStudentat>();
    test="Test from mobex";
    transcriptDisplay=false;
    CoursesTable=new Map<string,ICourse>();  
    TranscriptTable=new Map<string,IStudentCourses>();
    
   
    constructor(){
        makeAutoObservable(this)
    }
    loadStudentat= async ()=>{
       try{
        const students=await agent.Students.list();
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
    openCorses=async(id:string)=>{
        try{
           const courses=await agent.Students.enrollments(id);
           this.CoursesTable.clear();
           runInAction(()=>{
            courses.forEach(course=>{
               
                this.CoursesTable.set(course.id,course);
        })
       this.coursesDisplay=true;
        })
       
    }

   
    
        
        catch(error){
            console.log(error);
        }
    }
    get Courses(){
        return Array.from(this.CoursesTable.values());
    }

    
    closeCourses=()=>{
        this.coursesDisplay=false;
    }   
    openTrascript=async (id:string)=>{

    try{
        const marks=await agent.Students.transcript(id);
        this.TranscriptTable.clear();
        runInAction(()=>{
         marks.forEach(mark=>{
            
             this.TranscriptTable.set(mark.id,mark);
     })
     this.transcriptDisplay=true;
     })
     
 }
     
     catch(error){
         console.log(error);
     }
 }
 get Transkript(){
     return Array.from(this.TranscriptTable.values());
 }
    
    closeTranscript=()=>{
        this.transcriptDisplay=false;
    }   
    selectStudenti=(id:string)=>{
        
     // this.selectedStudenti!=this.StudentatRegistry.get(id);
    }
    canceleSelectedTermini=()=>{
        this.selectedStudenti=undefined;
    }
}