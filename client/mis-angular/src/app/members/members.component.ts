import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-members',
  templateUrl: './members.component.html',
  styleUrls: ['./members.component.css']
})
export class MembersComponent implements OnInit {
  @Output() onCount = new EventEmitter<number>();
  constructor() { }

  ngOnInit() {
  }
  count(counter: number) {
    this.onCount.emit(counter);
  }
}
