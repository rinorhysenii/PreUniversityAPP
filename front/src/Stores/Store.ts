import { createContext, useContext } from "react";
import StudentatStore from "./StudentatStore";

interface Store {
   StudentatStore:StudentatStore;
}

export const store: Store = {
    StudentatStore: new StudentatStore(),
   
}
export const StoreContext = createContext(store);

export function useStore(){
    return useContext(StoreContext);
}

interface StoreStudentat{
    StudentatStore:StudentatStore;
}

export const StoreStudentat:StoreStudentat={
    StudentatStore:new StudentatStore()
}

export const StoreContextStudentat=createContext(StoreStudentat);


export function useStoreStudentat(){
    return useContext(StoreContextStudentat);
}