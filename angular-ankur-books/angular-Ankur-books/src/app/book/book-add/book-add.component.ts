import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { IAddBook } from 'src/app/Models/addBook';
import { LoginService } from 'src/app/Service/auth.service';
import { BookService } from '../book.service';

@Component({
  selector: 'app-book-add',
  templateUrl: './book-add.component.html',
  styleUrls: ['./book-add.component.css']
})
export class BookAddComponent implements OnInit {

  constructor(private authService:BookService,private router:Router) { }
  

  ngOnInit(): void {
  }
  AddDetails:IAddBook={
    name:'',
    description:'',
    amount:0,
    author:''
    
  }
  addBook()
  {
    this.authService.addBook(this.AddDetails)
        .subscribe((res:any)=>{
          // console.log(this.AddDetails)
          this.router.navigate(['book'])
          
        })
  }
}
