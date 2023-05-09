import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent {
  name:string = ""
  gender:string = ""
  @Output() onInput = new EventEmitter<string>();
  @Output() onSelect = new EventEmitter<string>();

  onInputChange() {
    this.onInput.emit(this.name);
  }

  onSelectChange() {
    this.onSelect.emit(this.gender);
  }
}
