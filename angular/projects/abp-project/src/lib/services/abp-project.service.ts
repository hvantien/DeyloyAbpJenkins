import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class AbpProjectService {
  apiName = 'AbpProject';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/AbpProject/sample' },
      { apiName: this.apiName }
    );
  }
}
