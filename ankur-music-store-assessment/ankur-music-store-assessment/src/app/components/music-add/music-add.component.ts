import { Component, OnInit } from '@angular/core';
import { IMusic } from 'src/app/models/music';

@Component({
  selector: 'app-music-add',
  templateUrl: './music-add.component.html',
  styleUrls: ['./music-add.component.css']
})
export class MusicAddComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  music:IMusic=
  {
    language : '',
    category :'',
    singer:'',
    type:'',
  }
  message:string = ''
  classStyle:string="";
  addMusic()
  {
    console.log(this.music);
    alert("Music Saved Successfully")
    this.message ="Music saved successfully";
    this.classStyle = "alert alert-success";

  }
  check():boolean
  {
     return !!this.addMusic;  
  }
}
