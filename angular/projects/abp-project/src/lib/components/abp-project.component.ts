import { Component, OnInit } from '@angular/core';
import { AbpProjectService } from '../services/abp-project.service';

@Component({
  selector: 'lib-abp-project',
  template: ` <p>abp-project works!</p> `,
  styles: [],
})
export class AbpProjectComponent implements OnInit {
  constructor(private service: AbpProjectService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
