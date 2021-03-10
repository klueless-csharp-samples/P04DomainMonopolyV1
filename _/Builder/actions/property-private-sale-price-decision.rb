DddResourceBuilder.new
  .init
  .resource_key('action:property:private-sale-price-decision')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
