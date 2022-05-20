import { Component, OnInit } from '@angular/core';
import { IAddBook } from 'src/app/Models/addBook';
import { IBook } from '../book';
import { BookService } from '../book.service';

@Component({
    selector: 'app-booklist',
    templateUrl: 'bookList.component.html'
})

export class BookListComponent implements OnInit {
    constructor(private _bookService:BookService) {
       
    }

    book:IBook []=[]
    isBookDataAvailable: boolean = false;
    editBook:IBook= {
        id:0,
    name:'',
    amount:0,
    author:'',
    description:''
    }
    Id:number = 0
    Alphabet:string = ''
    
    
    ngOnInit(): void {
        this._bookService.getBook()
            .subscribe((data: IBook[]) => {
                this.isBookDataAvailable = true;
                // console.log(data);
                
                this.book = data;
            });
        }
    
        

        }
        
