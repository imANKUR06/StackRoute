import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IBook } from './book';
import {Observable} from 'rxjs';
import { IAddBook } from '../Models/addBook';
import { IRegister } from '../Models/register';
import { IEditBook } from '../Models/editBook';
import { environment } from 'src/environments/environment';

@Injectable({providedIn: 'root'})
export class BookService {
    baseApiUrl: string = environment.baseUrl+"api/book"
    addUrl:string =  environment.baseUrl+'api/book/CreateBook' 
    registerUrl:string =  environment.baseUrl+ 'api/authentication/register'   
    editUrl =  environment.baseUrl+ 'api/Book/'
    
    constructor(private httpClient: HttpClient) {
        
     }

    getBook(): Observable<IBook[]>{        
        return this.httpClient.get<IBook[]>(this.baseApiUrl)
    }
    addBook(add:IAddBook)
    {
        return this.httpClient.post<IAddBook>(this.addUrl,add)
    }
    register(registerData:IRegister)
    {
        return this.httpClient.post<IRegister>(this.registerUrl,registerData)
    }
    getBookbyId(id:number){
        return this.httpClient.get<IBook>(this.editUrl+id)
    }
    onEdit(id:number,add:IAddBook)
    {
        return this.httpClient.put<IBook>(this.editUrl+id,add)
    }
    onDelete(id:number)
    {
        return this.httpClient.delete(this.editUrl+id,{responseType:'text'})
    }
    getName(name:string):Observable<IBook[]>
    {
        return this.httpClient.get<IBook[]>(this.editUrl+name)
    }
    
}