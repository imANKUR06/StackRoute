import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IBook } from '../book';
import { BookService } from '../book.service';

@Component({
  selector: 'app-search-name',
  templateUrl: './search-name.component.html',
  styleUrls: ['./search-name.component.css']
})
export class SearchNameComponent implements OnInit {

  constructor(private authService:BookService,private router:ActivatedRoute) { }
  book: IBook[]=[]

  ngOnInit(): void {
    this.authService.getName(this.router.snapshot.params['name'])
        .subscribe((res:IBook[])=>{
          this.book = res
          console.log("added name with book")
        })
  }

}
