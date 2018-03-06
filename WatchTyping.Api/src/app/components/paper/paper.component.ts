import { Component, OnInit, EventEmitter, Output, Input } from '@angular/core';

@Component({
  selector: 'app-paper',
  templateUrl: './paper.component.html',
  styleUrls: ['./paper.component.css']
})
export class PaperComponent implements OnInit {

  @Output() onTyping = new EventEmitter<string>();
  @Input() text: string = ""

  constructor() { }

  ngOnInit() {
  }

  typing() {
    this.onTyping.emit(this.text);
  }

}
