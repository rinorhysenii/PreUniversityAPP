import axios, { AxiosResponse } from 'axios';
import { ICourse } from '../intefaces/Course';
import { IStudentat } from '../intefaces/IStudentat';
import { IStudentCourses } from '../intefaces/IStudentCourses';
import { ITeacher } from '../intefaces/ITeacher';
import { IMark } from '../intefaces/Mark';
import { Register } from '../intefaces/Register';

axios.defaults.baseURL = 'https://localhost:44375';

const responseBody = <T> (response: AxiosResponse <T> ) => response.data;

const requests = {
    get: <T> (url: string) => axios.get<T>(url).then(responseBody),
    post: <T> (url: string, body: {}) => axios.post<T>(url, body).then(responseBody),
    put: <T> (url: string, body: {}) => axios.put<T>(url, body).then(responseBody),
    del: <T> (url: string) => axios.delete<T>(url).then(responseBody),
}




const Students={
    list: () => requests.get<IStudentat[]>('/Student'),
    details: (studentId: string) => requests.get<IStudentat>(`/Student/${studentId}`),
    enrollments:(id:string)=>requests.get<ICourse[]>(`/Student/allcourses/${id}`),
    average:(id:string)=>requests.get<Number>(`/Student/average/${id}`),
    transcript:(id:string)=>requests.get<IStudentCourses[]>(`/Students/transript/${id}`)
}

const Teachers={
    list: () => requests.get<ITeacher[]>('/Teacher/getAllTeachers'),
}
const Courses={
    list:()=> requests.get<ICourse[]>('/Course/getAllCourses'),
    details:(courseid:string)=> requests.get<ICourse>(`/Course/getCourse/${courseid}`),
    getMark:(courseid:string,studentId:string)=> requests.get<Number>(`/Course/getMark/${courseid}/${studentId}`),
    addmark:(mark:IMark)=> requests.post<void>(`/Course/addmark`,mark),
    editmark:(mark:IMark)=> requests.put<void>('/Course',mark),

}

const Parent={
    childs: (id:string) => requests.get<IStudentat[]>(`/Parent/${id}`),
    childsTranscript:(id:string)=>requests.get<IStudentCourses[]>(`/Parent/transcript/${id}`),
    average:(id:string)=>requests.get<Number>(`/Parent/average/${id}`),

}
const Account={
    login:(userdata:Register)=>requests.post<void>('/Account/login',userdata),
    Register:(userdata:Register)=>requests.post<void>('/Account',userdata),
    logout:()=>requests.get<void>('/Account/logout')
}

const agent={
    Students,
    Teachers,
    Courses,
    Parent,
    Account
};

export default agent