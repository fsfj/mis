import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'mis-angular';
  counter: number = 0;

  count(eventData: number) {
    console.log(eventData);
    this.counter += eventData;
  }
}
