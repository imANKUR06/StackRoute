import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IAddBook } from 'src/app/Models/addBook';
import { BookService } from '../book.service';

@Component({
  selector: 'app-book-delete',
  templateUrl: './book-delete.component.html',
  styleUrls: ['./book-delete.component.css']
})
export class BookDeleteComponent implements OnInit {

  constructor(private authService:BookService,private router:Router,private route:ActivatedRoute) { }
  
  Id:number=0;
  book:IAddBook={
    name:'',
    amount:0,
    author:'',
    description:''

  }

  ngOnInit(): void {
    this.authService.getBookbyId(this.route.snapshot.params['id'])
        .subscribe((res:any)=>{
          console.log(res)
          this.Id = res.id
          this.book = res
        })
        
  }

  onDelete()
  {
    console.log("delete Done")
    this.authService.onDelete(this.Id)
        .subscribe((res:any)=>{
          
          this.router.navigate(['/book'])
       })    
  }

}
