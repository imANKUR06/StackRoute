import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IAddBook } from 'src/app/Models/addBook';
import { BookService } from '../book.service';

@Component({
  selector: 'app-book-edit',
  templateUrl: './book-edit.component.html',
  styleUrls: ['./book-edit.component.css']
})
export class BookEditComponent implements OnInit {

  constructor(private route:ActivatedRoute,private authService:BookService,private router:Router) { }
  editDetails:IAddBook={
    name:'',
    description:'',
    amount:0,
    author:''
    
  }
  Id:number=0
  ngOnInit(): void {
    this.authService.getBookbyId(this.route.snapshot.params['id']).subscribe((res:any)=>{
      console.log(res)
      this.Id= res.id
      this.editDetails = res
    })
  }
  onEdit()
  {
    this.authService.onEdit(this.Id,this.editDetails)
        .subscribe((res:any)=>{
          // console.log("Edit Done")
          this.router.navigate(['book'])
        })
  }

}
