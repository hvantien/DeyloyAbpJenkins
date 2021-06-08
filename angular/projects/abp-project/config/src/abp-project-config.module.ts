import { ModuleWithProviders, NgModule } from '@angular/core';
import { ABP_PROJECT_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class AbpProjectConfigModule {
  static forRoot(): ModuleWithProviders<AbpProjectConfigModule> {
    return {
      ngModule: AbpProjectConfigModule,
      providers: [ABP_PROJECT_ROUTE_PROVIDERS],
    };
  }
}
