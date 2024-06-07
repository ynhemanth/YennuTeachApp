import { Component, OnInit } from '@angular/core';
import { DataService } from '../services/data.service';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';


@Component({
  selector: 'app-dropdown',
  standalone: true,
  imports: [ ReactiveFormsModule,
    FormsModule],
  templateUrl: './dropdown.component.html',
  styleUrl: './dropdown.component.css'
})
export class DropdownComponent implements OnInit {
  data: any[] = [];
  selectedValue: any;

  constructor(private dataService: DataService) { }

  ngOnInit(): void {
    this.dataService.getData().subscribe(
      (response) => {        
        this.data = response;        
      },
      (error) => {
        console.error('Error fetching data:', error);
      }
    );
  }
}
