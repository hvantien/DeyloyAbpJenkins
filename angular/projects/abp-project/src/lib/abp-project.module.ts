import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { AbpProjectComponent } from './components/abp-project.component';
import { AbpProjectRoutingModule } from './abp-project-routing.module';

@NgModule({
  declarations: [AbpProjectComponent],
  imports: [CoreModule, ThemeSharedModule, AbpProjectRoutingModule],
  exports: [AbpProjectComponent],
})
export class AbpProjectModule {
  static forChild(): ModuleWithProviders<AbpProjectModule> {
    return {
      ngModule: AbpProjectModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<AbpProjectModule> {
    return new LazyModuleFactory(AbpProjectModule.forChild());
  }
}
