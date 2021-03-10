DddResourceBuilder.new
  .init
  .resource_key('action:player:pay-income-tax-calculated')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
