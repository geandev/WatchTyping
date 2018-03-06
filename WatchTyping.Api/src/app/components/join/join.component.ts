import { Component, OnInit, Output, EventEmitter, Input } from '@angular/core';

@Component({
  selector: 'app-join',
  templateUrl: './join.component.html',
  styleUrls: ['./join.component.css']
})
export class JoinComponent implements OnInit {

  @Output() onJoin = new EventEmitter<string>();
  @Input() code: string;

  constructor() { }

  ngOnInit() {
  }

  join() {
    this.onJoin.emit(this.code)
  }
}
