import axios, { AxiosResponse } from 'axios';
import { IStudentat } from '../intefaces/IStudentat';
import { ITeacher } from '../intefaces/ITeacher';

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
    
}

const Teachers={
    list: () => requests.get<ITeacher[]>('/Teacher/getAllTeachers'),
    details: (id: string) => requests.get<IStudentat>(`/Teacher/${id}`),

}
const agent={
    Students,
    Teachers,
};

export default agent